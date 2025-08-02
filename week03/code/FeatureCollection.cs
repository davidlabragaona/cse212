using System.Data.Common;
using System.Net.Mime;
using System.Security.Cryptography;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public string type { get; set; }
    public Metadata metadata { get; set; }
    public decimal[] bbox { get; set; }
    public Feature features { get; set; }
}

public class Metadata
{
    public long generated { get; set; }
    public string url { get; set; }
    public string title { get; set; }
    public string api { get; set; }

    public int count { get; set; }

    public int status { get; set; }
}

public class Feature
{
    public Properties properties { get; set; }
}

public class Properties {
    public decimal mag { get; set; }
    public string place { get; set; }
    public long time { get; set; }
    public long updated { get; set; }
    public int tz { get; set; }
    public string url { get; set; }
    public string detail { get; set; }
    public int felt { get; set; }
    public decimal cdi { get; set; }
}
