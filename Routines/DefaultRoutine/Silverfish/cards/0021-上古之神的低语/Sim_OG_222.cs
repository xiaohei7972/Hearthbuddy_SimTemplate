using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_222 : SimTemplate //* 集结之刃 Rallying Blade
//<b>Battlecry:</b> Give +1/+1 to your minions with <b>Divine Shield</b>.
//<b>战吼：</b>使你具有<b>圣盾</b>的随从获得+1/+1。 
    {
        

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_222);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.divineshild) p.minionGetBuffed(m, 1, 1);
            }
        }
    }
}