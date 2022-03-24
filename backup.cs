using GTA;
using GTA.Math;
using GTA.Native;
using System;
using System.Windows.Forms;

namespace gta5_interiors_props_manager
{
    public class Main : Script
    {

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                Vector3 characterPosition = Game.Player.Character.Position;

                int interiorId = Function.Call<int>(
                    Hash.GET_INTERIOR_AT_COORDS,
                    characterPosition.X,
                    characterPosition.Y,
                    characterPosition.Z
                );
                int PDinteriorId = Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 451.0129, -993.3741, 29.1718);
                bool isValidInterior = Function.Call<bool>(Hash.IS_VALID_INTERIOR, interiorId);

                bool isInteriorReady = Function.Call<bool>(Hash.IS_INTERIOR_READY, interiorId);

                // Если интерьер не валидный или не готов к использованию прерываем выполнение.
                if (!isValidInterior || !isInteriorReady) return;

                string inputMethod = Game.GetUserInput();

                // В зависимости от введенного метода выполняем логику.
                switch (inputMethod)
                {
                    case "enable":
                    case "disable":
                        {
                            string inputEntitySetName = Game.GetUserInput();

                            Function.Call(
                                inputMethod == "enable"
                                    ? Hash.ACTIVATE_INTERIOR_ENTITY_SET
                                    : Hash.DEACTIVATE_INTERIOR_ENTITY_SET,
                                interiorId,
                                inputEntitySetName
                            );

                            break;
                        }

                    case "refresh":
                        {
                            Function.Call(Hash.REFRESH_INTERIOR, interiorId);

                            break;
                        }
                }
            }
        }
        private void enablePD(string e)
        {
            if (e == "yes")
            {
                int PDinteriorId = Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 451.0129, -993.3741, 29.1718);
                bool isValidInterior = Function.Call<bool>(Hash.IS_VALID_INTERIOR, PDinteriorId);

                bool isInteriorReady = Function.Call<bool>(Hash.IS_INTERIOR_READY, PDinteriorId);

                // Если интерьер не валидный или не готов к использованию прерываем выполнение.
                if (!isValidInterior || !isInteriorReady) return;
                //int handle = Function.Call<int>(Hash.REGISTER_PEDHEADSHOT, Game.Player.Character);
                //string txd = Function.Call<string>(Hash.GET_PEDHEADSHOT_TXD_STRING, handle);
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm1")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm1");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm2")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm2");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm3")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm3");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm4")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm4");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm5")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm5");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm6")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm6");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm7")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm7");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm8")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm8");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm9")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm9");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm10")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm10");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm11")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm11");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm12")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm12");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm13")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm13");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm14")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm14");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm15")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm15");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm16")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm16");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm17")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm17");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm18")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm18");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm19")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm19");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm20")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm20");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm21")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm21");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm22")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm22");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm23")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm23");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm24")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm24");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm25")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm25");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm26")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm26");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm27")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm27");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm28")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm28");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm29")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm29");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm30")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm30");
                if (!Function.Call<bool>(Hash.IS_INTERIOR_ENTITY_SET_ACTIVE, PDinteriorId, "v_gabz_mrpd_rm31")) Function.Call(Hash.ACTIVATE_INTERIOR_ENTITY_SET, PDinteriorId, "v_gabz_mrpd_rm31");
                Function.Call(Hash.REFRESH_INTERIOR, PDinteriorId);
                //Function.Call(Hash.BEGIN_TEXT_COMMAND_THEFEED_POST, "STRING");
                //Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, "Loaded Mission Row Police Department successfully!");
                //Function.Call(Hash.END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT, txd, txd, false, 0, "Tweak_MOD_Handler", "Notification");
                //Function.Call(Hash.END_TEXT_COMMAND_THEFEED_POST_TICKER, false, true);
            }
        }    
        */
        public Main()
        {
            KeyDown += onKeyDown;
            enablePD("yes")
        }
    }
}
