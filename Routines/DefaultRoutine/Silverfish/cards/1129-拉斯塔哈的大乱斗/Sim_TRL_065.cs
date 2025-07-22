using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_065: SimTemplate //* 祖尔金 Zul'jin
//[x]<b>Battlecry:</b> Cast all spellsyou've played this game<i>(targets chosen randomly)</i>.
//<b>战吼：</b>施放你在本局对战中使用过的所有法术<i>（目标随机而定）</i>。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.setNewHeroPower(CardDB.cardIDEnum.TRL_065h, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
			
			int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			
            if (ownplay)
            {
                if (p.ownMinions.Count < p.enemyMinions.Count) p.evaluatePenality -= 15;
                else p.evaluatePenality -= 5;
                foreach (Minion m in p.ownMinions) m.Ready = false;
                foreach (Minion m in p.enemyMinions) m.frozen = true;
                p.ownHero.Hp += 7;
            }
        }
    }
}