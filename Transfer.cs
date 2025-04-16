using System;
using System.Security.Cryptography.X509Certificates;

public class Transfer
{
    public long threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }
    public Transfer(long threshold, int low_fee, int high_fee)
	{
		this.threshold = threshold;
        this.low_fee = low_fee;
        this.high_fee = high_fee;
	}

}


