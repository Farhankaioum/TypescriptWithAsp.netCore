using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Console
{
    class Program
    {
        private static List<List<string>> MakeNewList(List<string> items, int columnCount)
        {
            var listGroups = new List<List<string>>();

            var count = (int)Math.Ceiling((double)items.Count() / columnCount);

            for (int i = 0; i < count; i++)
            {
                var groups = new List<string>();

                if (items.Count >= columnCount)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        groups.Add(items[j]);
                    }

                    items.RemoveRange(0, columnCount);

                }
                else
                {
                    int totalRemove = 0;
                    for (int k = 0; k < items.Count(); k++)
                    {
                        groups.Add(items[k]);
                        totalRemove = k;
                    }

                    items.RemoveRange(0, totalRemove);
                }

                listGroups.Add(groups);

            }
            return listGroups;
        }

        private static int MaxWordCounterFromListOfList(List<List<string>> itemsInItmes)
        {
            int totalCount = 0;
            foreach (var items in itemsInItmes)
            {
                int count = WordCharCounter(items);

                if (count > totalCount)
                {
                    totalCount = count;
                }
            }

            return totalCount;
        }

        private static int WordCharCounter(List<string> items)
        {
            int count = 0;

            foreach (var item in items)
            {
                count += item.Length;
            }

            return count;
        }

        private static int TotalItemCounter(List<string> items)
        {
            return items.Count();
        }

        static void Main(string[] args)
        {
            var itemNames = new List<string>();
            int columnCount = 6;
            int maxLengthItem = 0;
            var returnList = new List<string>();

            itemNames.Add("Blackcurrant");
            itemNames.Add("Apple");
            itemNames.Add("Blackberries");
            itemNames.Add("Apricots");
            itemNames.Add("Banana");
            itemNames.Add("Avocado");
            itemNames.Add("Breadfruit");
            itemNames.Add("Blueberries");

            itemNames.Sort();
            //System.Console.WriteLine("Sorting list: ");
            //foreach (var item in data)
            //{
            //    System.Console.WriteLine(item);
            //}

            var newList = MakeNewList(itemNames, columnCount);

            maxLengthItem = MaxWordCounterFromListOfList(newList) + (columnCount - 1);

            foreach (var items in newList)
            {
                int charCount = WordCharCounter(items) + (columnCount -1);

                var newFormattedItems = new StringBuilder();

                if (charCount == maxLengthItem)
                {
                    foreach (var item in items)
                    {
                        newFormattedItems.Append(item);
                        newFormattedItems.Append('*');
                    }
                    newFormattedItems.Remove(newFormattedItems.Length - 1, 1);
                    returnList.Add(newFormattedItems.ToString());
                    System.Console.WriteLine(newFormattedItems);
                }
                else
                {
                    var totalSpace = maxLengthItem - (charCount - (columnCount - 1));
                    var perWordSpace = totalSpace / (columnCount - 1);
                    var totalItemsInList = TotalItemCounter(items) - 1;

                    var restOfTheSpace = totalSpace - (totalItemsInList * perWordSpace);

                    for (int i = 0; i < items.Count; i++)
                    {
                        if (i == items.Count - 1)
                        {
                            newFormattedItems.Append(items[i]);
                            for (int j = 0; j < restOfTheSpace; j++)
                            {
                                newFormattedItems.Append('*');
                            }
                        }
                        else
                        {
                            newFormattedItems.Append(items[i]);
                            for (int j = 0; j < perWordSpace; j++)
                            {
                                newFormattedItems.Append('*');
                            }

                        }
                    }
                    returnList.Add(newFormattedItems.ToString());
                    System.Console.WriteLine(newFormattedItems);
                }
            }

            //foreach (var item in newList)
            //{
            //    foreach (var i in item)
            //    {
            //        System.Console.Write(i + " ");
            //    }
            //    System.Console.WriteLine();
            //}

        }
    }
}
