import request from '@/utils/request'

export function getLogs(data) {
  return request({
    url: 'api/logs/query',
    method: 'post',
    data
  })
}

export default { getLogs }
