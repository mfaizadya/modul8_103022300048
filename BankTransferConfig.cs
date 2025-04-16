using System;
using System.Text.Json;

public class BankTransferConfig
{

	Config config;
	public string filePath = @"bank_transfer_config.json";

    public BankTransferConfig()
	{
		try
		{
			ReadConfigFile();
		}
		catch
		{
			config = new Config();
			config.lang = "en";
			config.transfer = new Transfer(25000000, 6500, 15000);
			List<string> aa = new List<string>();
			config.methods.Add("RTO (real-time)");
			config.methods.Add("SKN (real-time)");
			config.methods.Add("RTGS (real-time)");
			config.methods.Add("BI FAST (real-time)");
			config.confirmation = new Confirmation("yes", "ya");
			WriteNewConfigFile();
		}
	}

	private void ReadConfigFile()
	{
		string configJsonData = File.ReadAllText(filePath);
		config = JsonSerializer.Deserialize<Config>(configJsonData);
	}

	private void WriteNewConfigFile()
	{
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };
        String jsonString = JsonSerializer.Serialize(config, options);
        File.WriteAllText(filePath, jsonString);
    }

    

}


