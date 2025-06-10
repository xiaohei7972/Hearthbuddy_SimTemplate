using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_830: SimTemplate //* 暗影收割者安度因 Shadowreaper Anduin
//<b>Battlecry:</b> Destroy all minions with 5 or more_Attack.
//<b>战吼：</b>消灭所有攻击力大于或等于5的随从。 
    {
        
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.ICC_830p, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;

            foreach (Minion m in p.enemyMinions)
            {
                if (m.Angr >= 5) p.minionGetDestroyed(m);
            }
            foreach (Minion m in p.ownMinions)
            {
                if (m.Angr >= 5) p.minionGetDestroyed(m);
            }
        }
    }
}