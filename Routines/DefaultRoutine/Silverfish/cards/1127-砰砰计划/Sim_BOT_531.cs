using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_531 : SimTemplate //* 星界密使 Celestial Emissary
//<b>Battlecry:</b> Your next spell_this turn has <b>Spell_Damage +2</b>.
//<b>战吼：</b>在本回合中，你的下一个法术将获得<b>法术伤害+2</b>。 
	{
        
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                p.spellpower+=2;
            }
            else
            {
                p.enemyspellpower+=2;
            }
		}
	}
}