using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_428 : SimTemplate //* 游园迷梦 Lost in the Park
	{
        //<b>Questline:</b> Gain 4 Attack with your hero. <b>Reward:</b> Gain 5 Armor.
        //<b>任务线：</b>使你的英雄获得4点攻击力。<b>奖励：</b>获得5点护甲值。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_428, questProgress = 0, maxProgress = 4 };
        }

    }
}
