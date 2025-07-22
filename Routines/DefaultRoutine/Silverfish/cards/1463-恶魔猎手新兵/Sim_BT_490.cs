using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_490 : SimTemplate //* 吞噬魔法 Consume Magic
	{
        //<b>Silence</b> an enemy_minion.<b>Outcast:</b> Draw a card.
        //<b>沉默</b>一个敌方随从。<b>流放：</b>抽一张牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
        {
            p.minionGetSilenced(target);
            if (outcast)
            {
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
            //base.onCardPlay(p, ownplay, target, choice, outcast);
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
    }
}
