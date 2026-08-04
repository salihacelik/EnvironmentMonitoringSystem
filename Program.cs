using System;
using System.Threading;

Console.WriteLine("Ortam Analiz Sistemi Başlatıldı...");

while (true)
{
    // Sistem odaları, fabrikalar veya seralar için örnek sensör değerleri simülasyonu
    double sicaklik = 22.5; // sıcaklık[cite: 1]
    double basinc = 1012.0; // basınç[cite: 1]
    double nem = 45.5; // nem[cite: 1]
    double ses = 60.0; // ses[cite: 1]
    double oksijen = 20.9; // oksijen[cite: 1]
    double karbondioksit = 400.0; // karbondioksit[cite: 1]
    bool dumanVarMi = false; // duman[cite: 1]
    double voltaj = 220.0; // voltaj[cite: 1]

    Console.WriteLine($"\n[{DateTime.Now:HH:mm:ss}] Veriler Okundu:");
    Console.WriteLine($"Sıcaklık: {sicaklik}°C, \nBasınç: {basinc}hPa, \nNem: %{nem}");
    Console.WriteLine($"Ses: {ses}dB, \nO2: %{oksijen}, \nCO2: {karbondioksit}ppm");
    Console.WriteLine($"Duman: {(dumanVarMi ? "Tehlike!" : "Yok")}, \nVoltaj: {voltaj}V");

    // Sistemi her 30 saniyede bir kontrol eder[cite: 1]
    Thread.Sleep(30000); 
}