using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：6 攻击力：5 生命值：5
	//Shudderblock
	//沙德木刻
	//[x]<b>Miniaturize</b><b>Battlecry:</b> Your next <b>Battlecry</b>triggers 3 times, but can't_damage the enemy hero.
	//<b>微缩</b><b>战吼：</b>你的下一个<b>战吼</b>会触发3次，但无法伤害敌方英雄。
	class Sim_TOY_501 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果：抽一张衍生物牌
            CardDB.Card miniaturizedCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_501t); // 假设 TOY_501t 是衍生物的卡牌ID
            p.drawACard(miniaturizedCard.cardIDenum, ownplay, true);
        }

        public override void getBattlecryEffect(Playfield p, Minion ownMinion, Minion target, int choice)
        {
            if (ownMinion.own)
            {
                // 设置玩家下一个战吼效果触发三次的标志
                p.nextBattlecryTriggers = 3;
            }
        }

    }
}
