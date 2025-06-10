using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_252: SimTemplate //* 冰冷鬼魂 Coldwraith
//<b>Battlecry:</b> If an enemy is <b>Frozen</b>, draw a card.
//<b>战吼：</b>如果有敌人被<b>冻结</b>，抽一张牌。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            bool frozen = false;
            if (m.own ? p.enemyHero.frozen : p.ownHero.frozen) frozen = true;

            if (!frozen)
            {
                List<Minion> temp = (m.own) ? p.enemyMinions : p.ownMinions;
                foreach (Minion mnn in temp)
                {
                    if (mnn.frozen)
                    {
                        frozen = true;
                        break;
                    }
                }
            }

            if (frozen) p.drawACard(CardDB.cardIDEnum.None, m.own);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FROZEN_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}