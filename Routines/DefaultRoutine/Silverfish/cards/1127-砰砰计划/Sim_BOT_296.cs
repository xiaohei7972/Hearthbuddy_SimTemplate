using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_296 : SimTemplate //* 欧米茄防御者 Omega Defender
//[x]<b>Taunt</b><b>Battlecry:</b> If you have10 Mana Crystals,gain +10 Attack.
//<b>嘲讽，战吼：</b>如果你有十个法力水晶，获得+10攻击力。 
    {
        
		
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (p.ownMaxMana ==10)
			{
				p.minionGetBuffed(m, 10, 0);
			}
        }


    }
}