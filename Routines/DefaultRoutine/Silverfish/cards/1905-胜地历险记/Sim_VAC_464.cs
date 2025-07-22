using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：6 攻击力：4 生命值：5
	//Treasure Hunter Eudora
	//财宝猎人尤朵拉
	//[x]<b>Battlecry:</b> Go on a <b>Sidequest</b>to <b>Discover</b> amazing loot!Play 3 cards from otherclasses to complete it.
	//<b>战吼：</b>开启一项使用3张其他职业的牌即可完成的<b>支线任务</b>，<b>发现</b>神奇的战利品！
	class Sim_VAC_464 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 战吼效果：开始一个支线任务，使用3张其他职业的牌来完成
            if (own.own)
            {
                p.ownQuest = new Questmanager.QuestItem()
                {
                    Id = CardDB.cardIDEnum.VAC_464,
                    questProgress = 0,
                    maxProgress = 3,
                };
            }
        }
    }
}
