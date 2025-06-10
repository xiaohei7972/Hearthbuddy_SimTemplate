using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_003 : SimTemplate //* 符文秘银杖 Runed Mithril Rod
	{
        //[x]After you draw 4 cards,reduce the Cost of cardsin your hand by (1).Lose 1 Durability.
        //在你抽四张牌后，使你的手牌法力值消耗减少（1）点。失去1点耐久度。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_003), true);
        }

    }
}
