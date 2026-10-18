public class TimeMap {
    public TimeMap(
    ) {}

    Dictionary<string, List<ValueTimestamp>> timeMap = new Dictionary<string, List<ValueTimestamp>>();
    public void Set(string key, string value, int timestamp) {
        if (!timeMap.ContainsKey(key)){
            timeMap[key] = new List<ValueTimestamp>();
            timeMap[key].Add(new ValueTimestamp(value,timestamp));
        } else{
            timeMap[key].Add(new ValueTimestamp(value,timestamp));
        }
    }

    public string Get(string key, int timestamp) {
        if(!timeMap.ContainsKey(key)){
            return "";
        }
        string closest ="";
        return binarySearch(timeMap[key], timestamp, 0, timeMap[key].Count - 1,closest);
    }

    public string binarySearch(List<ValueTimestamp> list, int target, int leftLimit, int rightLimit,string closest) {

        int mid = leftLimit + (rightLimit - leftLimit) / 2;
        if (leftLimit > rightLimit) {
            return closest;
        }
        if(list[mid].TimeStamp==target){
            return list[mid].Value;
        }
        if (list[mid].TimeStamp < target) {
            closest = list[mid].Value;
            return binarySearch(list, target, mid + 1, rightLimit,closest);
        } else {
            return binarySearch(list, target, leftLimit, mid - 1,closest);
        }
    }

    public class ValueTimestamp{

        public ValueTimestamp(string value, int timeStamp){
            Value = value;
            TimeStamp = timeStamp;
        }
        public string Value{get;set;}
        public int TimeStamp{get;set;}
    }
}