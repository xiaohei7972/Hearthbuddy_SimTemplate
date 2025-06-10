using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_128 : SimTemplate //* 真菌宝藏 Fungal Fortunes
	{
        //Draw 3 cards. Discard any minions drawn.
        //抽三张牌。弃掉抽到的所有随从牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, true, false);
            p.drawACard(CardDB.cardIDEnum.None, true, false);
            p.drawACard(CardDB.cardIDEnum.None, true, false);
        }

    }
}
