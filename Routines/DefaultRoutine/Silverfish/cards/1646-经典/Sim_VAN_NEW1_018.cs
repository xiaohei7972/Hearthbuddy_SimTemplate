using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_NEW1_018 : SimTemplate //* 血帆袭击者 Bloodsail Raider
	{
		//<b>Battlecry:</b> Gain Attack equal to the Attackof your weapon.
		//<b>战吼：</b>获得等同于你的武器攻击力的攻击力。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
             own.Angr += p.ownWeapon.Angr;
        }

    }
}
