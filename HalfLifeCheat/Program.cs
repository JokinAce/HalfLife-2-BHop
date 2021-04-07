using System;

namespace HalfLifeCheat {

    internal static class Program {

        private static void Main() {
            Rewrite rewrite = new Rewrite("hl2");


            Console.Title = "HL2 Bhop Cheat | github.com/JokinAce";
            Console.WriteLine("Half-Life 2 Cheat | github.com/JokinAce\n----------------------------\n1. Half-Life 2\n2. Half-Life 2 EP.1\n3. Half-Life 2 EP.2\n----------------------------\nChoose a Game (Number):");

            string Number = Console.ReadLine();

            if (Number == "1" && rewrite.CheckProcess()) {
                // ForceJump = client.dll + 48BF5C
                // Flags = "server.dll"+00634174, 380 Host only <- Shit, not updating fast enough

                int ClientDLL = (int)rewrite.GetDLL("client.dll");
                FinalMSG(ClientDLL);

                while (true) {
                    if (rewrite.IsKeyPushedDown(System.Windows.Forms.Keys.Space)) {
                        rewrite.WriteInt(ClientDLL + 0x48BF5C, 5);
                        rewrite.WriteInt(ClientDLL + 0x48BF5C, 4);
                    }
                }
            } else if (Number == "2" && rewrite.CheckProcess()) {
                // ForceJump = client.dll + 4993DC
                int ClientDLL = (int)rewrite.GetDLL("client.dll");
                FinalMSG(ClientDLL);

                while (true) {
                    if (rewrite.IsKeyPushedDown(System.Windows.Forms.Keys.Space)) {
                        rewrite.WriteInt(ClientDLL + 0x4993DC, 5);
                        rewrite.WriteInt(ClientDLL + 0x4993DC, 4);
                    }
                }
            } else if (Number == "3") {
                // FJ = client.dll+4993DC
                int ClientDLL = (int)rewrite.GetDLL("client.dll");
                FinalMSG(ClientDLL);

                while (true) {
                    if (rewrite.IsKeyPushedDown(System.Windows.Forms.Keys.Space)) {
                        rewrite.WriteInt(ClientDLL + 0x4993DC, 5);
                        rewrite.WriteInt(ClientDLL + 0x4993DC, 4);
                    }
                }
            }

            void FinalMSG(int ClientDLL) {
                Console.WriteLine($"ClientDLL - 0x{ClientDLL:X}");
                Console.WriteLine("Happy Jumping");
            }
        }
    }
}