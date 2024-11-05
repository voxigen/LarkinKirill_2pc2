class Coin
{
    public string name { get; set; }
    public int sell { get; set; }
    public List<string> tags { get; set; }
    public Coin (string n, int s)
    {
        name = n;
        sell = s;
    }
    public void AddTags (string name)
    {
        tags.Add (name);
    }
    
}

