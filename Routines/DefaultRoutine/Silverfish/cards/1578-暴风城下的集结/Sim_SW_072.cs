using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_072 : SimTemplate //* 锈烂蝰蛇 Rustrot Viper
	{
		//[x]<b>Tradeable</b><b>Battlecry:</b> Destroy youropponent's weapon.
		//<b>可交易</b><b>战吼：</b>摧毁对手的武器。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                p.lowerWeaponDurability(1000, false);
            }
            else
            {
                p.lowerWeaponDurability(1000, true);
            }
		}
	}
}
