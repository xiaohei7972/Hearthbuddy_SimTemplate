using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_377 : SimTemplate //* 九命兽魂 Nine Lives
//<b>Discover</b> a friendly <b>Deathrattle</b> minion that died this game. Also trigger its <b>Deathrattle</b>.
//<b>发现</b>一个在本局对战中死亡的友方<b>亡语</b>随从，并触发其<b>亡语</b>。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_014); 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
        }
    }
}