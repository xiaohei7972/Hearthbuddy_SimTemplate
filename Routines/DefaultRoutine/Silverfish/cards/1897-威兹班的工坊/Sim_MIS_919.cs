using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 潜行者 费用：4
	//Puppet Theatre
	//木偶剧场
	//[x]Choose an enemyminion. Get a 1/1 copyof it that costs (1).
	//选择一个敌方随从，获取一张它的1/1且法力值消耗为（1）点的复制。
	class Sim_MIS_919 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 检查目标是否为有效的敌方随从
            if (target != null && !target.own)
            {
                // 复制目标随从的卡牌信息
                CardDB.Card copyCard = target.handcard.card;

                // 创建该随从的1/1复制
                Handmanager.Handcard newHandCard = new Handmanager.Handcard
                {
                    card = copyCard,
                    manacost = 1 // 设置复制随从的法力值消耗为1
                };

                // 创建并设置复制随从的属性
                newHandCard.card.Attack = 1;
                newHandCard.card.Health = 1;

                // 将这张复制卡牌加入到己方手牌
                p.drawACard(newHandCard.card.cardIDenum, true, true);
            }
        }

        public override PlayReq[] GetUseAbilityReqs()
        {
            return new PlayReq[]
            {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),   // 目标必须是敌方随从
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),  // 目标必须是一个随从
            };
        }
    }
}
