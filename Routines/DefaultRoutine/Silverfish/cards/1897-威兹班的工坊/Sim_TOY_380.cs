using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：6 攻击力：3 生命值：7
	//Clay Matriarch
	//黏土巢母
	//[x]<b>Miniaturize</b><b>Taunt</b>. <b>Deathrattle:</b> Summona 4/4 Whelp with <b>Elusive</b>.
	//<b>微缩</b><b>嘲讽</b>。<b>亡语：</b>召唤一条4/4并具有<b>扰魔</b>的雏龙。
	class Sim_TOY_380 : SimTemplate
	{

        // 亡语效果
        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 召唤一个 4/4 并具有“扰魔”的雏龙
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_380t2), m.zonepos, m.own);
        }

        // 如果微缩效果需要实现，假设微缩是召唤一个衍生物
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果：假设微缩效果是抽一张衍生物牌
            CardDB.Card miniaturizedCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_380t); // 假设衍生物牌ID为 TOY_380t
            if (miniaturizedCard != null)
            {
                p.drawACard(miniaturizedCard.cardIDenum, ownplay, true);
            }
        }
    }
}
