using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_124 : SimTemplate //* 孤胆英雄 Lone Champion
//<b>Battlecry:</b> If you control no other minions, gain <b>Taunt</b> and <b>Divine Shield</b>.
//<b>战吼：</b>如果你没有控制其他随从，则获得<b>嘲讽</b>和<b>圣盾</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			int mCount = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
			if (mCount < 0) 
			{
				m.divineshild = true;
				m.taunt = true;
			}
			
        }
    }
}