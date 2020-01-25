using System;

public class Car
{
    public Car()
    {

    }
    // Practice writing methods and classes without adding semi-colons!!

    public int CarYear { get; set; }
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public string EngineNoise { get; set; }
    public string BeeperHorn { get; set; }
    public bool IsDriveable { get; set; }

    public void EngineSound(string engineNoise)
    {
        EngineNoise = engineNoise;
    }

    public void HornNoise(string beeperHorn) 
    {
        HornNoise = beeperHorn;
        
    }


}







