using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：6 攻击力：2 生命值：10
	//Incindius
	//伊辛迪奥斯
	//[x]At the end of your turn,upgrade your Eruptions.<b>Battlecry:</b> Shuffle 5 Eruptions in your deck.
	//在你的回合结束时，你的爆发升级。<b>战吼：</b>将5张爆发洗入你的牌库。
	class Sim_VAC_321 : SimTemplate
	{
        CardDB.Card eruptionCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_321t); // 爆发卡的ID

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 洗入5张爆发牌
            for (int i = 0; i < 5; i++)
            {
                p.AddToDeck(eruptionCard);
            }
        }

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                // 升级玩家牌库中的爆发牌
            }
        }
    }
}
