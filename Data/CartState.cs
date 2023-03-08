using Shop.Goods;
using Shop.DataBase;

//namespace shopBlazor.Data
//{
    public class CartState
    {

        public event EventHandler OnAddToCart;
        public event EventHandler OnDeleteFromCart;
        public List<TechItem> _techitems = new List<TechItem>();

        public void AddItem(TechItem techItem)
        {
            _techitems.Add(techItem);
            OnAddToCart?.Invoke(techItem,EventArgs.Empty);
        }
        public void RemoveItem(TechItem techItem)
        {
            _techitems.Remove(techItem);
            OnDeleteFromCart?.Invoke(techItem,EventArgs.Empty);
        }
        public List<TechItem> GetItems()
        {
            return _techitems;
        }

        public double GetTotalSumm()
        {
            return this._techitems.Sum(x=>x.cost);
        }

        public void SellWithCash()
        {
            using (StoreDBContext dbcontext = new StoreDBContext())
            {
                dbcontext.GoodsQueries.SoldItems(_techitems);
            }    
            _techitems.Clear();
        }

    }
//}