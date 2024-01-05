namespace Packt.CloudySkiesAir.Chapter2; 

public class Fee {
  public decimal Total { get; set; }

  public void ChargeCarryOnBaggageFee(decimal fee, string chargeName) {
    Console.WriteLine($"{chargeName}: {fee}");
    Total += fee;
  }
}
