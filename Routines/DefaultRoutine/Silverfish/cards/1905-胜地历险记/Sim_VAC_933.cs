using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：1 攻击力：1 生命值：1
	//Patches the Pilot
	//飞行员帕奇斯
	//[x]<b>Battlecry:</b> Shuffle sixParachutes into your deckthat summon a 1/1 Pirate_____with <b>Charge</b> when drawn.___
	//<b>战吼：</b>将六张降落伞洗入你的牌库。当抽到降落伞时，召唤一个1/1并具有<b>冲锋</b>的海盗。
	 class Sim_VAC_933 : SimTemplate
    {
        // 战吼效果
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 将六张降落伞洗入牌库
            for (int i = 0; i < 6; i++)
            {
                p.drawACard(CardDB.cardIDEnum.VAC_933t, own.own, true); // true表示将卡牌洗入牌库而非直接抽取
            }
        }
    }
}