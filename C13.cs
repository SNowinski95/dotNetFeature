using System.Buffers;

namespace test
{
    internal class C13
    {
        public (Eg minTwo, Eg maxOne,int coutOfEg) NewBy(IEnumerable<Eg> egs)
        {
            //min by
            var minTwo = egs.MinBy(n => n.NumberTwo);
            //max by
            var maxOne = egs.MaxBy(n => n.NumberOne);
            //count by 
            var coutOfEg = egs.CountBy(n => n.Name).Single(n=>n.Key == "eg");
            return (minTwo, maxOne, coutOfEg.Value);
        }
        //agragate by
        //one case
        public object NewAgragateBy(IEnumerable<Eg> egs)
        {
            var res = egs.AggregateBy(n => n.Name, func: (total, eg) => total += eg.NumberOne + eg.NumberTwo, seed:0);
            return res;
        }
        //fast search for collection
        public bool fastSearchString(string[] strings)
        {
            var search= SearchValues.Create(strings,StringComparison.OrdinalIgnoreCase);
            return search.Contains("xyz");
        }
        //finish task in end order
        public async Task TaskManagment()
        {
            List<Task<int>> ints = [countTo(10000), countTo(100), countTo(2000), countTo(2)];
            //await the same order like in collection
            //var res = await Task.WhenAll(ints);
            //await in complete order (its faster)
            await foreach (var task in Task.WhenEach(ints))
            {
                await task;
            }
        }
        private async Task<int> countTo(int to)
        {
            var i = 0;
            for (i = 0; i < to; i++)
            {
                Task.Delay(10);
            }
            return i;
        }
        public int getFromEnd(int[] array, int indexFromLast)
        {
           return array[^indexFromLast];
        }
        //new param for collection (requred add) 
        public string newParams(params List<string> args)
        {
            return string.Join(" ", args);
        }
        //addctional in API HybridCache (roking in memory and also in eg. redis) and request files

    }
}
