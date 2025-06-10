using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：2 生命值：1
	//Tidepool Pupil
	//潮池学徒
	//[x]<b>Battlecry:</b> If you've cast 3spells while holding this,<b>Discover</b> one of them.@<i>({0} left!)</i>@<i>(Ready!)</i>
	//<b>战吼：</b>如果你在此牌在你手中时施放过3个法术，从中<b>发现</b>一张。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
	class Sim_VAC_304 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 检查是否满足条件，即在手中施放了3个法术
            if (own.handcard.conditionalCount >= 3 && own.handcard.conditionalList != null && own.handcard.conditionalList.Count > 0)
            {
                // 确保choice在有效范围内
                if (choice >= 0 && choice < own.handcard.conditionalList.Count)
                {
                    // 获取选择的卡牌ID
                    CardDB.cardIDEnum selectedCardId = own.handcard.conditionalList[choice];

                    // 抽取并添加选中的卡牌到手牌中
                    p.drawACard(selectedCardId, own.own, true);
                }
            }
        }
    }
}
