using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_300 : SimTemplate //* 古尔丹之手 Hand of Gul'dan
	{
        //When you playor discard this,draw 3 cards.
        //当你使用或弃掉这张牌时，抽三张牌。
        public override void onHandCardRemoved(Playfield p, Handmanager.Handcard hc)
        {
            p.drawACard(CardDB.cardIDEnum.None, true);
            p.drawACard(CardDB.cardIDEnum.None, true);
            p.drawACard(CardDB.cardIDEnum.None, true);
            return;
        }

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }
    }
}
