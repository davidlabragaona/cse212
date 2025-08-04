using System.Data.Common;
using System.Net.Mime;
using System.Security.Cryptography;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Metadata metadata { get; set; }
    public decimal[] bbox { get; set; }
    public Feature[] features { get; set; }
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

public class Property
{
    public decimal? mag { get; set; }
    public string place { get; set; }
    public long? time { get; set; }
    public long? updated { get; set; }
    public int? tz { get; set; }
    public string url { get; set; }
    public string detail { get; set; }
    public int? felt { get; set; }
    public decimal? cdi { get; set; }
    public decimal? mmi { get; set; }
    public string alert { get; set; }
    public string status { get; set; }
    public int? tsunami { get; set; }
    public int? sig { get; set; }
    public string net { get; set; }
    public string code { get; set; }
    public string ids { get; set; }
    public string sources { get; set; }
    public string types { get; set; }
    public int? nst { get; set; }
    public decimal? dmin { get; set; }
    public decimal? rms { get; set; }
    public decimal? gap { get; set; }
    public string magType { get; set; }
    public string type { get; set; }
}

public class Feature
{
    public Property properties { get; set; }
    public Geometry geometry { get; set; }
    public string id { get; set; }
}

public class Geometry
{
    public decimal[] coordinates { get; set; }
}