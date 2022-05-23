import request from "@/utils/request";

//内存历史记录
export function GetHistory(data) {
  return request({
    url: "Api/MemoryInstalled/GetHistory",
    method: "post",
    data
  });
}

//人工安装内存
export function InstallMemory(data) {
  return request({
    url: "Api/MemoryInstalled/ManualInstallationMemory",
    method: "post",
    data
  });
}

export default { GetHistory, InstallMemory };
