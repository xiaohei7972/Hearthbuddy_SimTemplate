using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_301 : SimTemplate //* 恶魔卫士 Felguard
	{
		//<b>Taunt</b><b>Battlecry:</b> Destroy one of your Mana Crystals.
		//<b>嘲讽，战吼：</b>摧毁你的一个法力水晶。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                p.ownMaxMana--;
            }
            else
            {
                p.enemyMaxMana--;
            }
		}


	}
}