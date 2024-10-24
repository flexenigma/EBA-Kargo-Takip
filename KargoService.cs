using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public class KargoService
{
    private readonly ILogger<KargoService> _logger;

    public KargoService(ILogger<KargoService> logger)
    {
        _logger = logger;
    }

    public async Task<Kargo> GetKargoByTakipNoAsync(string takipNo)
    {
        try
        {
            _logger.LogInformation("Kargo takip başlatıldı: {TakipNo}", takipNo);
            // Kargo veritabanı işlemleri
            return new Kargo(); // Örnek, gerçek veritabanı işlemi burada yapılmalı.
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Kargo takibi sırasında hata oluştu: {takipNo}");
            throw;
        }
    }
}
