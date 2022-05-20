# FFXIVOpcodes_Fork_Sync-with-Gitee
A Mirror Repo of FFXIVOpcodes which will sync with gitee for Chinese users.

[Reference](https://github.com/ffxiv-teamcraft/ffxiv-teamcraft/issues/2262)

This Repo will sync the fork branch with its upstream automatically.
After the sync, Github Action will sync the repo with its copy in Gitee, which will be accessible to Chinese users.

The main branch contains the Github Action files with will sync this repo automatically.

The fork branch contains the copy of upstream.

Update: A Chinese domestic organization has provided a same mirror for TC, this repo will be suspended.

[Reference](https://github.com/ffxiv-teamcraft/pcap-ffxiv/pull/31)
---

# FFXIVOpcodes 的Gitee同步仓库
[本仓库](https://github.com/Mundanity-fc/FFXIVOpcodes_Fork_Sync-with-Gitee/)为 [FFXIVOpcodes](https://github.com/karashiiro/FFXIVOpcodes) 仓库（下称上游仓库）的一个镜像，同时本仓库与 Gitee 中一个[同名仓库](https://gitee.com/mundanity/FFXIVOpcodes_Fork_Sync-with-Gitee)保持同步更新。

[Teamcraft](https://github.com/ffxiv-teamcraft/ffxiv-teamcraft) 作为《最终幻想14》的一个辅助工具，其本身提供了一个游戏数据抓包功能（pcap），该功能的实现需要对游戏数据的状态码（opcode）进行分析，因此有了上游仓库的功能。Teamcraft 在开启了抓包功能后，会默认从该上游仓库中获取最新的状态码对照表，但由于大陆网络环境的特殊性，大部分用户无法直接从 raw.githubusercontent.com 中获取到文件内容，因而之前都选用了 JsDelivr 作为国内的CDN。

但由于国内 JsDelivr 的连接不稳定，偶尔会出现无法访问的情况，所以会影响到 Teamcraft 的数据抓取功能。于是本仓库通过 Github Action 来实现对上游仓库的定时同步，同时在同步结束后，会和 Gitee 中的一个同名仓库进行同步更新。国内用户在使用 Teamcraft 的时候可以通过访问 Gitee 中的文件来获取状态码对照表。

对于本仓库做法的可靠性，存在以下问题：
  - Gitee 不一定保证未来可靠。2022 年 5 月 18 日，Gitee 更新了其开源政策，仓库所有者需要保证仓库内容合法合规后才可转变为公开仓库。目前这一政策对未来 raw 文件获取的影响未知。
  - 采用 Github Action 的定时计划势必会有同步上的延迟，未来上游的更新可能无法即时反映到 Gitee 当中。（目前 Workflow 设置的是每四小时的三十分进行一次同步抓取）。
 
参见[本条issue](https://github.com/ffxiv-teamcraft/ffxiv-teamcraft/issues/2262)。

更新：鉴于已有国内备案注册站点提供镜像服务，本 repo 暂停工作，尽供参考。

相见此条 [issuee](https://github.com/ffxiv-teamcraft/pcap-ffxiv/pull/31)
