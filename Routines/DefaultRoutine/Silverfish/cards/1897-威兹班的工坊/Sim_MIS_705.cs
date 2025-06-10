using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Standardized Pack
	//标准的卡牌包
	//Add 5 random <b>Taunt</b> minions to your hand. They are <b>Temporary</b>.
	//随机将五张<b>嘲讽</b>随从牌置入你的手牌。这些牌为<b>临时</b>牌。
	class Sim_MIS_705 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 简化后的逻辑：直接抽取5张带有嘲讽效果的临时卡牌
            for (int i = 0; i < 5; i++)
            {
                p.drawTemporaryCard(CardDB.cardIDEnum.None, ownplay);
            }
        }
    }
}
