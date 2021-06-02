using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public class StorageService
    {
        private static StorageService instance;

        private Dictionary<string, Clothes> clothes;
        private event Action UpdateUI;

        private StorageService()
        {
            clothes = new Dictionary<string, Clothes>();
        }

        public static StorageService GetInstance()
        {
            if(instance == null)
            {
                instance = new StorageService();
            }
            return instance;
        }

        public Clothes GetItem(string name)
        {
            return clothes[name];
        }

        public void SetUpdateHandler(Action updateHandler)
        {
            UpdateUI += updateHandler;
        }

        public void AddItem(Clothes item)
        {
            if(clothes.ContainsKey(item.Name))
            {
                clothes.Remove(item.Name);
                clothes.Add(item.Name, item);
            }
            else
            {
                clothes.Add(item.Name, item);
            }
            UpdateUI?.Invoke();
        }

        public void DeleteItem(string name)
        {
            clothes.Remove(name);
            UpdateUI?.Invoke();
        }

        public List<Clothes> GetList()
        {
            var clothesList = new List<Clothes>();
            foreach(Clothes item in clothes.Values)
            {
                clothesList.Add(item);
            }
            return clothesList;
        }

        public void ClearStorage()
        {
            clothes.Clear();
        }
    }
}
