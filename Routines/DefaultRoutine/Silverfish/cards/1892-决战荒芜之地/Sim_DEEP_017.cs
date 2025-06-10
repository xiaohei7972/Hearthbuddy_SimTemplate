using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Mining Casualties
	//采矿事故
	//Summon two 1/1 Silver Hand Recruits with "<b>Deathrattle:</b> Summona 1/1 Frail Ghoul".
	//召唤两个1/1并具有“<b>亡语：</b>召唤一个1/1的脆弱的食尸鬼”的白银之手新兵。
	class Sim_DEEP_017 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 召唤1/1的白银之手新兵
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t), p.ownMinions.Count, ownplay);
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t), p.ownMinions.Count, ownplay);
        }

    }
}
