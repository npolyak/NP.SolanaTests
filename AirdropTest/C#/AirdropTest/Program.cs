using Solnet.Rpc;
using Solnet.Wallet;

namespace AirdropTest;

internal class Program
{
    static async Task Main(string[] args)
    {
        IRpcClient client = ClientFactory.GetClient(Cluster.DevNet);

        var acct = await client
            .GetAccountInfoAsync(new PublicKey("A2GKaAD5FZ2TfaRq55mgJht9R9e39SjitaHCKxcYPs46"));

        var requestResult = 
            await client.RequestAirdropAsync
            (
                "A2GKaAD5FZ2TfaRq55mgJht9R9e39SjitaHCKxcYPs46", 
                100_000_000);

        Console.WriteLine("Hello, World!");
    }
}
