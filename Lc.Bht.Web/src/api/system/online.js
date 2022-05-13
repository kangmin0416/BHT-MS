import request from '@/utils/request'

export function queryOnline(data) {
  return request({
    url: 'api/online/query',
    method: 'post',
    data
  })
}

export function deleteOnline(data) {
  return request({
    url: 'api/online/delete',
    method: 'post',
    data
  })
}
