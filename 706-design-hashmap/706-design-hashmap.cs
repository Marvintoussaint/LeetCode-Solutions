public class MyHashMap {
int [] array;
    public MyHashMap() {
            array = new int [1000001];
    }
    
    public void Put(int key, int value) {
        array[key] = value + 1;
    }
    
    public int Get(int key) {
            return array[key] -1;
    }
    
    public void Remove(int key) 
    {
          array[key] = 0;  
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */