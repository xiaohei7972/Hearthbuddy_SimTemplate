using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：10 攻击力：6 生命值：7
	//Factory Assemblybot
	//工厂装配机
	//<b>Miniaturize</b>At the end of your turn, summon a 6/7 Bot that attacks a random enemy.
	//<b>微缩</b>在你的回合结束时，召唤一个6/7的机器人并使其攻击一个随机敌人。
	class Sim_TOY_601 : SimTemplate
	{
        private static Random rng = new Random(); // 创建一个静态的随机数生成器
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_601t2);
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            // 仅在随从所有者的回合结束时触发效果
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                if (p.ownMinions.Count < 7) // 确保场上有空位
                {
                    int posi = triggerEffectMinion.zonepos;
                    // 召唤一个 6/7 的机器人
                    p.callKid(kid, posi, triggerEffectMinion.own); // 假设机器人的卡牌 ID 为 TOY_601t2
                    //Minion bot = p.ownMinions[p.ownMinions.Count - 1];

                }
            }
        }
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果，假设微缩效果是抽一张衍生物卡牌
            p.drawACard(CardDB.cardIDEnum.TOY_601t, ownplay, true); // 假设微缩生成的衍生物卡牌 ID 为 TOY_601t
        }
    }
}
