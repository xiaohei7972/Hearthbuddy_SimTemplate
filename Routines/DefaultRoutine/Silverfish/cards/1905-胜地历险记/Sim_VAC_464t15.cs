using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：5
	//Gnomish Army Knife
	//侏儒军刀
	//[x]Give a minion <b>Rush</b>,<b>Windfury</b>, <b>Divine Shield</b>,<b>Lifesteal</b>, <b>Poisonous</b>,<b>Taunt</b>, and <b>Stealth</b>.
	//使一个随从获得<b>突袭</b>，<b>风怒</b>，<b>圣盾</b>，<b>吸血</b>，<b>剧毒</b>，<b>嘲讽</b>以及<b>潜行</b>。
	class Sim_VAC_464t15 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                // 提示：赋予目标随从各种能力
                target.rush = 1;            // 突袭
                target.windfury = true;        // 风怒
                target.divineshild = true;     // 圣盾
                target.lifesteal = true;       // 吸血
                target.poisonous = true;       // 剧毒
                target.taunt = true;           // 嘲讽
                target.stealth = true;         // 潜行
            }
        }

        // 获取这张卡牌的使用条件
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),   // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),    // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),  // 目标必须是友方随从
            };
        }
    }
}
