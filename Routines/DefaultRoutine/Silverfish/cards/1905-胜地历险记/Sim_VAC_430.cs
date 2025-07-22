using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：4 生命值：1
	//Bloodsail Recruiter
	//血帆征兵员
	//<b>Battlecry:</b> <b>Discover</b> a Pirate.
	//<b>战吼：</b><b>发现</b>一张海盗牌。
	class Sim_VAC_430 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 模拟 "发现" 效果：从卡组中抽取一张随机牌（这里假设为海盗牌）
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }
    }
}
