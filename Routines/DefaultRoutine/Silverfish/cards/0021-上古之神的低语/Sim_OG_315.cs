using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_315 : SimTemplate //* 血帆教徒 Bloodsail Cultist
//<b>Battlecry:</b> If you control another Pirate, give your weapon +1/+1.
//<b>战吼：</b>如果你控制其他任何海盗，你的武器便获得+1/+1。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.entitiyID == own.entitiyID) continue;
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PIRATE)
                {
                    if (own.own)
                    {
                        if (p.ownWeapon.Durability > 0)
                        {
                            p.ownWeapon.Durability++;
                            p.ownWeapon.Angr++;
                            p.minionGetTempBuff(p.ownHero, 1, 0);
                            if (p.ownWeapon.card.nameCN == CardDB.cardNameCN.海盗之锚) p.evaluatePenality -= 5;
                            p.evaluatePenality -= 5;
                        }
                    }
                    else
                    {
                        if (p.enemyWeapon.Durability > 0)
                        {
                            p.enemyWeapon.Durability++;
                            p.enemyWeapon.Angr++;
                            p.minionGetBuffed(p.enemyHero, 1, 0);
                        }
                    }
                    break;
                }
            }
        }
    }
}