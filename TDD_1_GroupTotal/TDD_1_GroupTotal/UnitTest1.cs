using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using NSubstitute;

namespace TDD_1_GroupTotal
{
    [TestClass]
    public class UnitTest1
    {
        private List<Product<string, int>> _Products;
        private List<Product<string, int>> _Coffees;
        private List<Product<string, int>> _Lacks;
        private List<Product<string, string>> _ProductDoc;

        private List<Product<string, int>> InitProducts()
        {
            List<Item<string, int>> itemID = new List<Item<string, int>>();
            itemID.Add(new Item<string, int> { Field = "Id", Value = 1 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 2 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 3 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 4 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 5 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 6 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 7 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 8 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 9 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 10 });
            itemID.Add(new Item<string, int> { Field = "Id", Value = 11 });

            List<Item<string, int>> itemCost = new List<Item<string, int>>();
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 1 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 2 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 3 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 4 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 5 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 6 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 7 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 8 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 9 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 10 });
            itemCost.Add(new Item<string, int> { Field = "Cost", Value = 11 });

            List<Item<string, int>> itemRevenue = new List<Item<string, int>>();
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 11 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 12 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 13 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 14 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 15 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 16 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 17 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 18 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 19 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 20 });
            itemRevenue.Add(new Item<string, int> { Field = "Revenue", Value = 21 });

            List<Item<string, int>> itemSellPrice = new List<Item<string, int>>();
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 21 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 22 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 23 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 24 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 25 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 26 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 27 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 28 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 29 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 30 });
            itemSellPrice.Add(new Item<string, int> { Field = "SellPrice", Value = 31 });

            List<Item<string, string>> itemUnknown = new List<Item<string, string>>();
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "txxt" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "yzzy" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "uttu" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "eyui" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "eixt" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "oiso" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "plwg" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "ojse" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "obuo" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "pwid" });
            itemUnknown.Add(new Item<string, string> { Field = "itemUnknown", Value = "pwia" });


            List<Product<string, int>> result = new List<Product<string, int>>();

            for (int i = 0; i < 11; i++)
            {
                Product<string, int> p = new Product<string, int>();
                //1st ID
                p.Items.Add(itemID[i].Field, itemID[i].Value);
                //2st Cost
                p.Items.Add(itemCost[i].Field, itemCost[i].Value);
                //3st Revenue
                p.Items.Add(itemRevenue[i].Field, itemRevenue[i].Value);
                //4st SellPrice
                p.Items.Add(itemSellPrice[i].Field, itemSellPrice[i].Value);

                //add List
                result.Add(p);
            }

            return result;
        }

        private List<Product<string, int>> InitCoffees()
        {
            List<Item<string, int>> itemName = new List<Item<string, int>>();
            itemName.Add(new Item<string, int> { Field = "Name", Value = 1 });
            itemName.Add(new Item<string, int> { Field = "Name", Value = 2 });
            itemName.Add(new Item<string, int> { Field = "Name", Value = 3 });
            itemName.Add(new Item<string, int> { Field = "Name", Value = 4 });
            itemName.Add(new Item<string, int> { Field = "Name", Value = 5 });
            itemName.Add(new Item<string, int> { Field = "Name", Value = 6 });
            itemName.Add(new Item<string, int> { Field = "Name", Value = 7 });
            itemName.Add(new Item<string, int> { Field = "Name", Value = 8 });


            List<Item<string, int>> itemHeat = new List<Item<string, int>>();
            itemHeat.Add(new Item<string, int> { Field = "Heat", Value = 1 });
            itemHeat.Add(new Item<string, int> { Field = "Heat", Value = 2 });
            itemHeat.Add(new Item<string, int> { Field = "Heat", Value = 3 });
            itemHeat.Add(new Item<string, int> { Field = "Heat", Value = 4 });
            itemHeat.Add(new Item<string, int> { Field = "Heat", Value = 5 });
            itemHeat.Add(new Item<string, int> { Field = "Heat", Value = 6 });
            itemHeat.Add(new Item<string, int> { Field = "Heat", Value = 7 });
            itemHeat.Add(new Item<string, int> { Field = "Heat", Value = 8 });


            List<Item<string, int>> itemCC = new List<Item<string, int>>();
            itemCC.Add(new Item<string, int> { Field = "CC", Value = 11 });
            itemCC.Add(new Item<string, int> { Field = "CC", Value = 12 });
            itemCC.Add(new Item<string, int> { Field = "CC", Value = 13 });
            itemCC.Add(new Item<string, int> { Field = "CC", Value = 14 });
            itemCC.Add(new Item<string, int> { Field = "CC", Value = 15 });
            itemCC.Add(new Item<string, int> { Field = "CC", Value = 16 });
            itemCC.Add(new Item<string, int> { Field = "CC", Value = 17 });
            itemCC.Add(new Item<string, int> { Field = "CC", Value = 18 });


            List<Item<string, int>> itemPrice = new List<Item<string, int>>();
            itemPrice.Add(new Item<string, int> { Field = "Price", Value = 21 });
            itemPrice.Add(new Item<string, int> { Field = "Price", Value = 22 });
            itemPrice.Add(new Item<string, int> { Field = "Price", Value = 23 });
            itemPrice.Add(new Item<string, int> { Field = "Price", Value = 24 });
            itemPrice.Add(new Item<string, int> { Field = "Price", Value = 25 });
            itemPrice.Add(new Item<string, int> { Field = "Price", Value = 26 });
            itemPrice.Add(new Item<string, int> { Field = "Price", Value = 27 });
            itemPrice.Add(new Item<string, int> { Field = "Price", Value = 28 });



            List<Product<string, int>> result = new List<Product<string, int>>();

            for (int i = 0; i < 8; i++)
            {
                Product<string, int> p = new Product<string, int>();
                //1st ID
                p.Items.Add(itemName[i].Field, itemName[i].Value);
                //2st Cost
                p.Items.Add(itemHeat[i].Field, itemHeat[i].Value);
                //3st Revenue
                p.Items.Add(itemCC[i].Field, itemCC[i].Value);
                //4st SellPrice
                p.Items.Add(itemPrice[i].Field, itemPrice[i].Value);

                //add List
                result.Add(p);
            }

            return result;
        }
        private List<Product<string, int>> InitLack()
        {
            List<Product<string, int>> result = new List<Product<string, int>>();
            //A,B,C,D,E
            Product<string, int> p = new Product<string, int>();
            p.Items.Add("A", 1);
            p.Items.Add("B", 1);
            p.Items.Add("C", 1);
            p.Items.Add("D", 1);
            p.Items.Add("E", 1);
            result.Add(p);

            //A,B
            p = new Product<string, int>();
            p.Items.Add("A", 2);
            p.Items.Add("B", 2);
            result.Add(p);

            //D,E
            p = new Product<string, int>();
            p.Items.Add("D", 3);
            p.Items.Add("E", 3);
            result.Add(p);

            //B,D
            p = new Product<string, int>();
            p.Items.Add("B", 4);
            p.Items.Add("D", 4);
            result.Add(p);

            //C
            p = new Product<string, int>();
            p.Items.Add("C", 6);
            result.Add(p);

            //A,C,E
            p = new Product<string, int>();
            p.Items.Add("A", 5);
            p.Items.Add("C", 5);
            p.Items.Add("E", 5);
            result.Add(p);

            return result;
        }

        private List<Product<string, string>> InitProductDocs()
        {
            List<Product<string, string>> result = new List<Product<string, string>>();
            //A,B,C,D,E
            Product<string, string> p = new Product<string, string>();
            p.Items.Add("A", "A1");
            p.Items.Add("B", "B1");
            p.Items.Add("C", "C1");
            p.Items.Add("D", "D1");
            p.Items.Add("E", "1");
            result.Add(p);

            //A,B
            p = new Product<string, string>();
            p.Items.Add("A", "A2");
            p.Items.Add("B", "B2");
            result.Add(p);

            //D,E
            p = new Product<string, string>();
            p.Items.Add("D", "D3");
            p.Items.Add("E", "3");
            result.Add(p);

            //B,D
            p = new Product<string, string>();
            p.Items.Add("B", "B4");
            p.Items.Add("D", "D4");
            result.Add(p);

            //C
            p = new Product<string, string>();
            p.Items.Add("C", "C6");
            result.Add(p);

            //A,C,E
            p = new Product<string, string>();
            p.Items.Add("A", "A5");
            p.Items.Add("C", "C5");
            p.Items.Add("E", "5");
            result.Add(p);

            return result;
        }

        [TestInitialize]
        public void InitTest()
        {
            //初始化產品內容
            _Products = InitProducts();
            //初始化產品咖啡內容
            _Coffees = InitCoffees();
            //初始化不相同產品內容
            _Lacks = InitLack();
            //初始化產品說明
            _ProductDoc = InitProductDocs();
        }

        [TestMethod]
        public void Products_Field_Cost_Total_Group_3()
        {
            //arrange
            ILog log = Substitute.For<ILog>();
            GroupTotal<string, int> target = new GroupTotal<string, int>(log);
            List<int> expected = new List<int>{ 6, 15, 24, 21 };

            //act
            target.SetCollections(_Products);
            List<int> actual = target.GetGroupSum("Cost", 3);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Products_Field_Revenue_Total_Group_4()
        {
            //arrange
            ILog log = Substitute.For<ILog>();
            GroupTotal<string, int> target = new GroupTotal<string, int>(log);
            List<int> expected = new List<int> { 50, 66, 60 };

            //act
            target.SetCollections(_Products);
            List<int> actual = target.GetGroupSum("Revenue", 4);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Products_Field_UnKnown_Total_0()
        {
            //arrange
            ILog log = Substitute.For<ILog>();
            GroupTotal<string, int> target = new GroupTotal<string, int>(log);
            List<int> expected = new List<int> { 0, 0, 0 };

            //act
            target.SetCollections(_Products);
            List<int> actual = target.GetGroupSum("UnKnown", 4);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Coffee_Field_CC_Total_Group_4()
        {
            //arrange
            ILog log = Substitute.For<ILog>();
            GroupTotal<string, int> target = new GroupTotal<string, int>(log);
            List<int> expected = new List<int> { 23, 27, 31, 35 };

            //act
            target.SetCollections(_Coffees);
            List<int> actual = target.GetGroupSum("CC", 2);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Lack_Field_C_Total_Group_2()
        {
            //arrange
            ILog log = Substitute.For<ILog>();
            GroupTotal<string, int> target = new GroupTotal<string, int>(log);
            List<int> expected = new List<int> { 3, 4, 0 };

            //act
            target.SetCollections(_Lacks);
            List<int> actual = target.GetGroupSum("B", 2);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductDoc_Field_E_Total_Group_5()
        {
            //arrange
            ILog log = Substitute.For<ILog>();
            GroupTotal<string, string> target = new GroupTotal<string, string>(log);
            List<int> expected = new List<int> { 1, 3, 5 };
            //act
            target.SetCollections(_ProductDoc);
            List<int> actual = target.GetGroupSum("E", 2);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Lack_Field_C_isNotExist_Log()
        {
            //arrange
            ILog log = Substitute.For<ILog>();
            GroupTotal<string, int> target = new GroupTotal<string, int>(log);
            //List<int> expected = new List<int> { 1, 0, 11 };

            //act
            target.SetCollections(_Lacks);
            List<int> actual = target.GetGroupSum("C", 2);

            //assert
            //CollectionAssert.AreEqual(expected, actual);
            log.Received(3).Save(Arg.Is<string>(x => x.Contains("C") && x.Contains("get Value failed")));
        }

        [TestMethod]
        public void ProductDoc_Field_D_Conver_To_Integer_Fail_Log()
        {
            //arrange
            ILog log = Substitute.For<ILog>();
            GroupTotal<string, string> target = new GroupTotal<string, string>(log);

            //act
            target.SetCollections(_ProductDoc);
            List<int> actual = target.GetGroupSum("D", 2);

            //assert
            log.Received(3).Save(Arg.Is<string>(x => x.Contains("D") && x.Contains("convert") && x.Contains("Integer failed")));
        }
    }

    public class GroupTotal<K, V>
    {
        private IEnumerable<Product<K, V>> _products;

        private ILog _log;

        public GroupTotal(ILog log)
        {
            this._log = log;
        }

        public void SetCollections(IEnumerable<Product<K, V>> products)
        {
            this._products = products;
        }

        public List<int> GetGroupSum(K id, int groupCount)
        {
            List<int> result = new List<int>();
            int count = 0;

            for (int i = 1; i <= _products.Count(); i++)
            {

                //取Field值
                int vaule = getFieldValue(_products.ElementAt(i - 1), id);
                //加總                
                count = count + vaule;

                //判斷Group
                if (i % groupCount == 0 || i == _products.Count() )
                {
                    //結果放入清單
                    result.Add(count);
                    count = 0;
                }
                
            }

            return result;
        }
        
        private int getFieldValue(Product<K, V> product, K key)
        {
            int result = 0;

            if (isFindKdy(product, key))
            {
                try
                {
                    //key有存在,取value轉int
                    result = Convert.ToInt32(product.Items[key]);
                }
                catch (Exception)
                {
                    //轉換失敗 throw;
                    writeLog(Error.ERROR_CONVER_TO_INTEGER_FAIL, key);
                }
                
            }
            else
            {
                //key不存在,紀錄log
                writeLog(Error.ERROR_IS_NOT_EXIST, key);
            }

            return result;
        }

        private bool isFindKdy(Product<K, V> product, K key)
        {
            bool result = false;

            if (product.Items.ContainsKey(key))
            {
                //key有存在
                result = true;
            }

            return result;
        }

        private void writeLog(int code, K id )
        {
            var content = string.Format("Field:[{0}] is not exist, get Value failed", id);

            switch (code)
            {
                case Error.ERROR_IS_NOT_EXIST:
                    content = string.Format("Field:[{0}] is not exist, get Value failed", id);
                    break;
                case Error.ERROR_CONVER_TO_INTEGER_FAIL:
                    content = string.Format("Field:[{0}] convert Value to Integer failed", id);
                    break;
                default:
                    content = string.Format("Field:[{0}] , Undefined failed", id);
                    break;
            }

            this._log.Save(content);
        }
    }

    public class Item<T1,T2>
    {
        public T1 Field { get; set; }
        public T2 Value { get; set; }
    }

    public class Product<K, V>
    {
        public Dictionary<K, V> Items { get; set; } = new Dictionary<K, V>();
        
    }
    public class Error
    {
        public const int ERROR_IS_NOT_EXIST = 1;
        public const int ERROR_CONVER_TO_INTEGER_FAIL = 2;
    }

    public interface ILog
    {
        void Save(string content);
    }
}
