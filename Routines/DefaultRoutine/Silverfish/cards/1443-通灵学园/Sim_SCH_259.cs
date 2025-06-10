using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_259 : SimTemplate //* 感知宝珠 Sphere of Sapience
	{
        //[x]At the start of your turn,look at your top card. Youcan put it on the bottom_and lose 1 Durability.
        //在你的回合开始时，检视你牌库顶的卡牌。你可以将其置于牌库底，并失去1点耐久度。
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_259);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
        }

    }
}
