using Rage;
using Rage.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPD_First_Response.Mod.API;
[assembly: Rage.Attributes.Plugin("MRPD Loader", Description = "LSPD interior.", Author = "Tweak")]
namespace MyFirstPlugin
{
    public class Main : Plugin
    {
        public override void Initialize()
        {
            Functions.OnOnDutyStateChanged += OnOnDutyStateChangedHandler;
            Game.LogTrivial("Plugin LSPDFR_API_MRPD " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + " has been initialised.");
            RegisterMRPD();
            Game.LogTrivial("Go on duty to fully load LSPDFR_API_Guide.");
        }
        public override void Finally()
        {
            Game.LogTrivial("LSPDFR_API_MRPD has been cleaned up.");
        }
        private static void OnOnDutyStateChangedHandler(bool OnDuty)
        {
            if (OnDuty)
            {
                Game.LogTrivial("LSPDFR_API_MRPD is loading MAP.");
                RegisterMRPD();
            }
        }
        private static void RegisterMRPD()
        {
            int PDinteriorId = NativeFunction.CallByName<int>("GET_INTERIOR_AT_COORDS", 436.491f, -982.172f, 30.699f);
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm1")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm1");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm2")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm2");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm3")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm3");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm4")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm4");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm5")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm5");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm6")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm6");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm7")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm7");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm8")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm8");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm9")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm9");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm10")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm10");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm11")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm11");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm12")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm12");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm13")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm13");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm14")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm14");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm15")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm15");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm16")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm16");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm17")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm17");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm18")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm18");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm19")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm19");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm20")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm20");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm21")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm21");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm22")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm22");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm23")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm23");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm24")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm24");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm25")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm25");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm26")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm26");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm27")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm27");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm28")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm28");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm29")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm29");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm30")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm30");
            if (!NativeFunction.Natives.IS_INTERIOR_ENTITY_SET_ACTIVE<bool>(PDinteriorId, "v_gabz_mrpd_rm31")) NativeFunction.Natives.ACTIVATE_INTERIOR_ENTITY_SET(PDinteriorId, "v_gabz_mrpd_rm31");
            NativeFunction.Natives.REFRESH_INTERIOR(PDinteriorId);
            Game.LogTrivial("LSPDFR_API_MRPD finished loading MAP.");
            Game.DisplayNotification("~b~Misson Row Police Department~s~, ~s~has been loaded ~g~successfully.");
        }

    }
}