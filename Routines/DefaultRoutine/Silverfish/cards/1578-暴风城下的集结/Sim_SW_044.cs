using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_044 : SimTemplate //* 杰斯·织暗 Jace Darkweaver
	{
		//<b>Battlecry:</b> Cast all Fel spells you've played this game (targets enemies if possible).</i>.
		//<b>战吼：</b>施放你在本局对战中使用过的所有邪能法术<i>（尽可能以敌人为目标）</i>。
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
          if(m.own)
            {
                if (p.ownMinions.Count < p.enemyMinions.Count) p.evaluatePenality -= 15;
                else p.evaluatePenality -= 5;
                foreach (Minion mm in p.ownMinions) mm.Ready = false;
                foreach (Minion mm in p.enemyMinions) mm.frozen = true;   
            }



        }


                       
		
	}
}
