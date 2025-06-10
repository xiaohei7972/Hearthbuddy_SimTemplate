using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_046 : SimTemplate //* 百兽之王 King of Beasts
//<b>Taunt</b>. <b>Battlecry:</b> Gain +1 Attack for each other Beast you have.
//<b>嘲讽，战吼：</b>你每控制一个其他野兽，便获得+1攻击力。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int bonusattack = 0;
            List<Minion> temp  = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.entitiyID == own.entitiyID) continue;
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET) bonusattack++;
            }
            p.minionGetBuffed(own, bonusattack, 0);
        }
    }
}