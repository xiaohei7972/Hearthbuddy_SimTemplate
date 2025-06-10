using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：4
	//Ghouls' Night
	//食尸鬼之夜
	//Summon five 1/1 Ghouls that attack random enemies.
	//召唤五个1/1的食尸鬼并使其攻击随机敌人。
	class Sim_VAC_445 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 5; i++)
            {
                // 召唤1/1的食尸鬼 (衍生物卡牌ID为 VAC_445t)
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_445t), p.ownMinions.Count, ownplay);
            }
        }
    }
}
