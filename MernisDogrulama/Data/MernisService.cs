using System;
using System.Threading.Tasks;
using static Mernis.KPSPublicSoapClient;

namespace MernisDogrulama.Data
{
    public class MernisService
    {
        public Task<bool> TcKimlikDogrula(Kullanici kullanici)
        {
            bool dogrulamaSonucu = false;
            try
            {
                var mernisClient = new Mernis.KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
                var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync(long.Parse(kullanici.tc_no), kullanici.ad, kullanici.soyad, kullanici.dogum_tarih.Year).GetAwaiter().GetResult();
                dogrulamaSonucu = tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
            }
            catch(Exception ex)
            {
                dogrulamaSonucu=false;
            }
            return Task.FromResult(dogrulamaSonucu);
        }
    }
}
