using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EBA_Kargo_Takip;
using Microsoft.Extensions.Logging;

public class KullaniciService
{
    private readonly IKullaniciRepository _kullaniciRepository;
    private readonly ILogger<KullaniciService> _logger;

    public KullaniciService(IKullaniciRepository kullaniciRepository, ILogger<KullaniciService> logger)
    {
        _kullaniciRepository = kullaniciRepository;
        _logger = logger;
    }

    public async Task<List<Kullanici>> GetAllKullanicilarAsync()
    {
        try
        {
            return await _kullaniciRepository.GetAllAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Kullanıcılar alınırken bir hata oluştu.");
            throw;
        }
    }

    public async Task<Kullanici> GetKullaniciByEmailAsync(string email)
    {
        try
        {
            return await _kullaniciRepository.GetKullaniciByEmailAsync(email);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"E-posta ile kullanıcı alınırken bir hata oluştu: {email}");
            throw;
        }
    }

    public async Task AddKullaniciAsync(Kullanici kullanici)
    {
        try
        {
            await _kullaniciRepository.AddAsync(kullanici);
            _logger.LogInformation("Yeni kullanıcı eklendi: {Email}", kullanici.Email);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Kullanıcı eklenirken bir hata oluştu.");
            throw;
        }
    }

    public async Task UpdateKullaniciAsync(Kullanici kullanici)
    {
        try
        {
            await _kullaniciRepository.UpdateAsync(kullanici);
            _logger.LogInformation("Kullanıcı güncellendi: {Email}", kullanici.Email);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Kullanıcı güncellenirken bir hata oluştu.");
            throw;
        }
    }

    public async Task DeleteKullaniciAsync(int id)
    {
        try
        {
            await _kullaniciRepository.DeleteAsync(id);
            _logger.LogInformation("Kullanıcı silindi: {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Kullanıcı silinirken bir hata oluştu.");
            throw;
        }
    }
}
