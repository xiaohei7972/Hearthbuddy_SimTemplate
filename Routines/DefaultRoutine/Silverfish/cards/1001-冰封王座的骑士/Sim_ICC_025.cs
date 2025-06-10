using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_025: SimTemplate //* 骷髅捣蛋鬼 Rattling Rascal
//[x]<b>Battlecry:</b> Summon a5/5 Skeleton.<b>Deathrattle:</b> Summon onefor your opponent.
//<b>战吼：</b>召唤一个5/5的骷髅。<b>亡语：</b>为你的对手召唤一个5/5的骷髅。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NAX4_03H); 

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.callKid(kid, m.zonepos, m.own);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            int pos = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, pos, !m.own);
        }
    }
}