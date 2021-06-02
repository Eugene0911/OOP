using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;
using ThirdLaboratory;
using System.Runtime.Serialization.Json;
using System.Collections;

namespace EncryptionPlugin
{
    public class CryptoService : IEncoder
    {
        private readonly string KEYS_FILE_NAME = "Parameters.json";

        private readonly string FILE_NAME;

        public CryptoService(string fileName)
        {
            FILE_NAME = fileName;
        }

        private void SaveParameters(byte[] key, byte[] iv)
        {
            Dictionary<string, (byte[], byte[])> parameters;
            var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, (byte[], byte[])>));

            using (var file = new FileStream(KEYS_FILE_NAME, FileMode.OpenOrCreate))
            {
                if (file.Length != 0)
                {
                    parameters = serializer.ReadObject(file) as Dictionary<string, (byte[], byte[])>;   
                }
                else
                {
                    parameters = new Dictionary<string, (byte[], byte[])>();
                }
                if(parameters.ContainsKey(FILE_NAME))
                {
                    parameters.Remove(FILE_NAME);
                }
                parameters.Add(FILE_NAME, (key, iv));
            }
            using(var file = new FileStream(KEYS_FILE_NAME, FileMode.Create))
            {
                serializer.WriteObject(file, parameters);
            }
        }

        private (byte[], byte[]) GetParameters()
        {
            using(var file = new FileStream(KEYS_FILE_NAME, FileMode.Open))
            {
                var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, (byte[], byte[])>));
                var parameters = serializer.ReadObject(file) as Dictionary<string, (byte[], byte[])>;
                return parameters[FILE_NAME];
            }
        }

        public byte[] Encrypt(byte[] data)
        {
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.GenerateIV();
                aes.GenerateKey();
                var encryptor = aes.CreateEncryptor();
                var result = encryptor.TransformFinalBlock(data, 0, data.Length);
                SaveParameters(aes.Key, aes.IV);
                return result;
            }
        }

        public byte[] Decrypt(byte[] data)
        {
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                var parameters = GetParameters();
                var decryptor = aes.CreateDecryptor(parameters.Item1, parameters.Item2);
                var result = decryptor.TransformFinalBlock(data, 0, data.Length);
                return result;
            }
        }
    }
}